using System;
using Contal.IwQuick.Data;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    [LwSerialize(338)]
    public enum CarReaderType : byte
    {
        [Name("Unknown")]
        Unknown = 0,
        [Name("IPCamera")]
        IPCamera = 1,
        [Name("ANPRCamera")]
        ANPRCamera = 2,
        [Name("Dahua")]
        Dahua = 3,
        [Name("Axis")]
        Axis = 4
    }
}
