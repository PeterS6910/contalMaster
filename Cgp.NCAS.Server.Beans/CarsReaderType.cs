using System;
using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    public class CarsReaderType : AOrmObject
    {
        public virtual Guid IdCarsReaderType { get; set; }
        public virtual int CameraTypeCode { get; set; }
        public virtual string Name { get; set; }
        public virtual string Model { get; set; }
        public virtual string Description { get; set; }
        public virtual string Version { get; set; }

        public virtual byte ObjectType
        {
            get { return (byte)ObjectType(); }
            set { }
        }

        public override bool Compare(object obj)
        {
            var carsReaderType = obj as CarsReaderType;
            return carsReaderType != null && carsReaderType.IdCarsReaderType == IdCarsReaderType;
        }

        public override string GetIdString()
        {
            return IdCarsReaderType.ToString();
        }

        public override object GetId()
        {
            return IdCarsReaderType;
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.NotSupport;
        }

        public override IModifyObject CreateModifyObject()
        {
            return null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
