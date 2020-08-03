using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestPower
{
    class Program
    {
        private static Guid NO_SUBGROUP_GUID = new Guid("fea3413e-7e05-4911-9a71-700331f1c294");
        private static Guid GUID_PROCESSOR_SETTINGS_SUBGROUP = new Guid("54533251-82be-4824-96c1-47b60b740d00");
        private static Guid GUID_PERFBOOSTMODE = new Guid("be337238-0d82-4146-a960-4f3749d470c7");

        [DllImport("powrprof.dll")]
        static extern uint PowerEnumerate(
     IntPtr RootPowerKey,
     IntPtr SchemeGuid,
     ref Guid SubGroupOfPowerSetting,
     uint AccessFlags,
     uint Index,
     ref Guid Buffer,
     ref uint BufferSize);

        [DllImport("powrprof.dll")]
        static extern uint PowerGetActiveScheme(
            IntPtr UserRootPowerKey,
            ref IntPtr ActivePolicyGuid);

        [DllImport("powrprof.dll")]
        static extern uint PowerReadACValue(
            IntPtr RootPowerKey,
            IntPtr SchemeGuid,
            IntPtr SubGroupOfPowerSettingGuid,
            ref Guid PowerSettingGuid,
            ref int Type,
            ref IntPtr Buffer,
            ref uint BufferSize
            );

        [DllImport("powrprof.dll", CharSet = CharSet.Unicode)]
        static extern uint PowerReadFriendlyName(
            IntPtr RootPowerKey,
            IntPtr SchemeGuid,
            IntPtr SubGroupOfPowerSettingGuid,
            IntPtr PowerSettingGuid,
            StringBuilder Buffer,
            ref uint BufferSize
            );

        [DllImport("kernel32.dll")]
        static extern IntPtr LocalFree(
            IntPtr hMem
            );

        private const uint ERROR_MORE_DATA = 234;

        static void Main(string[] args)
        {
            IntPtr activeGuidPtr = IntPtr.Zero;
            try
            {
                uint res = PowerGetActiveScheme(IntPtr.Zero, ref activeGuidPtr);
                if (res != 0)
                    throw new Win32Exception();

                //Get Friendly Name
                uint buffSize = 0;
                StringBuilder buffer = new StringBuilder();
                Guid subGroupGuid = Guid.Empty;
                Guid powerSettingGuid = Guid.Empty;
                res = PowerReadFriendlyName(IntPtr.Zero, activeGuidPtr,
                    IntPtr.Zero, IntPtr.Zero, buffer, ref buffSize);

                if (res == ERROR_MORE_DATA)
                {
                    buffer.Capacity = (int)buffSize;
                    res = PowerReadFriendlyName(IntPtr.Zero, activeGuidPtr,
                        IntPtr.Zero, IntPtr.Zero, buffer, ref buffSize);
                }

                if (res != 0)
                    throw new Win32Exception();

                Console.WriteLine("ReadFriendlyName = " + buffer.ToString());

                //Get the Power Settings
                Guid ProcessorSettingGuid = Guid.Empty;
                uint index = 0;
                uint BufferSize = Convert.ToUInt32(Marshal.SizeOf(typeof(Guid)));

                while (
    PowerEnumerate(IntPtr.Zero, activeGuidPtr, ref GUID_PERFBOOSTMODE,
    18, index, ref ProcessorSettingGuid, ref BufferSize) == 0)
                {
                    uint size = 4;
                    IntPtr temp = IntPtr.Zero;
                    int type = 0;
                    res = PowerReadACValue(IntPtr.Zero, activeGuidPtr, IntPtr.Zero,
                        ref ProcessorSettingGuid, ref type, ref temp, ref size);

                    IntPtr pSubGroup = Marshal.AllocHGlobal(Marshal.SizeOf(GUID_PROCESSOR_SETTINGS_SUBGROUP));
                    Marshal.StructureToPtr(GUID_PROCESSOR_SETTINGS_SUBGROUP, pSubGroup, false);
                    IntPtr pSetting = Marshal.AllocHGlobal(Marshal.SizeOf(GUID_PROCESSOR_SETTINGS_SUBGROUP));
                    Marshal.StructureToPtr(ProcessorSettingGuid, pSetting, false);

                    uint builderSize = 200;
                    StringBuilder builder = new StringBuilder((int)builderSize);
                    res = PowerReadFriendlyName(IntPtr.Zero, activeGuidPtr,
                        pSubGroup, pSetting, builder, ref builderSize);
                    Console.WriteLine(builder.ToString() + " = " + temp.ToString());
//                    if (ProcessorSettingGuid.Equals(GUID_PERFBOOSTMODE))
//                        Console.WriteLine("This one! ^^^");

                    index++;
                }

                Console.ReadLine();
            }
            finally
            {
                if (activeGuidPtr != IntPtr.Zero)
                {
                    IntPtr res = LocalFree(activeGuidPtr);
                    if (res != IntPtr.Zero)
                        throw new Win32Exception();
                }
            }
        }

    }
}

