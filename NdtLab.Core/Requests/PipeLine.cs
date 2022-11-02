﻿using NdtLab.core;
namespace NdtLab.Core.Requests
{
    public class PipeLine : Entity
    {
        /// <summary>
        /// Километр магистрального трубопровода
        /// </summary>
        public string Distance { get; set; }
        // надо ли сюда массив заявок засунуть?
        public override string ToString()
        {
            return $"{{ distance: {Distance}}}";
        }
    }
}
