namespace NdtLab.core.Welders
{
    public class Welder : Entity
    {
        public string FullName { get; set; }
        /// <summary>
        /// Клеймо
        /// </summary>
        public string Stamp { get; set; }
        public virtual ICollection<WelderJoint> WelderJoints { get; set; }

        public override string ToString()
        {
            return $"{{ Ф.И.О: {FullName}, клеймо: {Stamp}}}";
        }
    }
}
