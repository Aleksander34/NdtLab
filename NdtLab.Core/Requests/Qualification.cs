using NdtLab.core;

namespace NdtLab.Core.Requests
{
    public class Qualification : Entity
    {
        public TypeQualification Type { get;set;}
        public override string ToString()
        {
            return $"{{ Type of qualification: {Type}}}";
        }
    }
}
