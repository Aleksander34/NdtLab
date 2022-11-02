using NdtLab.core;
namespace NdtLab.Core.Requests
{
    public class PipeLine : Entity
    {
        /// <summary>
        /// Километр магистрального трубопровода
        /// </summary>
        public string Distance { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public override string ToString()
        {
            return $"{{ distance: {Distance}}}";
        }
    }
}
