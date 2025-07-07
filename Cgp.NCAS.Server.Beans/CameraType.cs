using System;
using Contal.Cgp.Globals;
using Contal.Cgp.Server.Beans;

namespace Contal.Cgp.NCAS.Server.Beans
{
    [Serializable]
    public class CameraType : AOrmObject
    {
        public virtual Guid IdCameraType { get; set; }
        public virtual int CameraTypeCode { get; set; }
        public virtual string Name { get; set; }
        public virtual string Model { get; set; }
        public virtual string Description { get; set; }
        public virtual string Version { get; set; }

        public virtual byte ObjectType
        {
            get { return (byte)ObjectType.NotSupport; }
            set { }
        }

        public override bool Compare(object obj)
        {
            var cameraType = obj as CameraType;
            return cameraType != null && cameraType.IdCameraType == IdCameraType;
        }

        public override string GetIdString()
        {
            return IdCameraType.ToString();
        }

        public override object GetId()
        {
            return IdCameraType;
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
