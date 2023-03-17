﻿using Application.EmployeeVacationTypes;

namespace Application.VacationTypes
{
    public class VacationTypeDto
    {

        public int? Id { get; set; }
        public string Name { get; set; }

        public virtual List<EmployeeVacationTypeDto>? EmployeeVacationTypes { get; set; }
    }
}
