﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlydienSinhvien.App_Form;

namespace QuanlydienSinhvien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            //Application.Run(new App_Form.FormMain());
            //Application.Run(new ClassManagerment.FormClass());
            //Application.Run(new SubjectManagerment.FormSubject());
            //Application.Run(new StudentManagerment.FormStudent());
            //Application.Run(new StudyResultsManagerment.FormStudyResults());
        }
    }
}
