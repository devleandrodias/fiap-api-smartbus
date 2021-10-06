using System.ComponentModel;

namespace SmartBusApi.Enuns
{
    public enum EVehicleCategory
    {
        [Description("Bus")]
        BUS = 'B',
        
        [Description("Van")]
        VAN = 'V',

        [Description("Small Bus")]
        SMALL_BUS = 'S',
    }
}
