using Karamolegkos_Christos_PrivateSchool.Repository;
using Karamolegkos_Christos_PrivateSchool.View.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karamolegkos_Christos_PrivateSchool.Controller
{
    class TrainerController
    {
        public void AllTrainers()
        {
            TrainerRepository service = new TrainerRepository();

            var tra = service.GetAll();
            ViewTrainer.AllTrainers(tra);

        }
    }
}

