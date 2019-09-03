using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicLabStudyApplication.Libs
{
    class FormInicjalizator
    {
        public static void openMainWindow()
        {
          
        }

        public static void openContactUsForm()
        {
            ContactUsForm contactUsForm = new ContactUsForm();
            contactUsForm.ShowDialog();
        }

        public static void openAboutUsForm()
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        public static void openServicesForm()
        {
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.ShowDialog();
        }

        public static void openDoctorsForm()
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.ShowDialog();
        }

        public static void openMedicinesForm()
        {
            MedicinesForm medicinesForm = new MedicinesForm();
            medicinesForm.ShowDialog();
        }
    }
}
