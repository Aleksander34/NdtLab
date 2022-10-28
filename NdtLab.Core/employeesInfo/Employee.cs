﻿using NdtLab.core;
using NdtLab.core.Inspections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NdtLab.Core.employeesInfo
{
    public class Employee: Entity
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public ICollection<Phone> Phones { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        [JsonIgnore]
        public Role Role { get; set; }

        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        [JsonIgnore]
        public Division Division { get; set; }

        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        [JsonIgnore]
        public Position Position { get; set; }
        [JsonIgnore]
        public virtual ICollection<InspectionEmployee> InspectionEmployees { get; set; }

        public override string ToString()
        {
            return $"{{ Фамилия: {LastName}, Имя: {Name} Отчество: {MiddleName}, Логин: {Login}, Пароль: {Password}, Электронная почта: {Email}, Роль: {RoleId}, Подразделение: {DivisionId}, Должность: {PositionId}}}";
        }
    }
}
