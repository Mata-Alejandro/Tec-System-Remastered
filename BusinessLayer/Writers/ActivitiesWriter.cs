﻿using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class ActivitiesWriter : EntityWriter<Academies>
    {
        public ActivitiesWriter(int operation, Academies entity) : base(operation, entity)
        {
        }

        public ActivitiesWriter(int operation, Academies entity, Academies entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
