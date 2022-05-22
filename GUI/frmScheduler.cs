using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Model;
namespace GUI
{
    public partial class frmScheduler : DevExpress.XtraEditors.XtraForm
    {
        StaffBUS staffBUS = new StaffBUS();
        AccountBUS accountBUS = new AccountBUS();
        TimeSheetBUS timeSheetBUS = new TimeSheetBUS();
        Staff staff = new Staff();
        TimeSheet timeSheet = new TimeSheet();
        public frmScheduler()
        {
            InitializeComponent();
            loadShifts();
            this.scTimeSheet.Start = DateTime.Now;
            scTimeSheet.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            scTimeSheet.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            scTimeSheet.Views.MonthView.AppointmentDisplayOptions.TimeDisplayType = DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text;
            scTimeSheet.Views.MonthView.AppointmentDisplayOptions.ShowReminder = false;
            this.schedulerDataStorage1.AppointmentInserting += SchedulerDataStorage1_AppointmentInserting;
            this.schedulerDataStorage1.AppointmentDeleting += SchedulerDataStorage1_AppointmentDeleting;
            this.schedulerDataStorage1.AppointmentChanging += SchedulerDataStorage1_AppointmentChanging;
            this.schedulerDataStorage1.AppointmentsInserted += SchedulerDataStorage1_AppointmentsInserted;
        }

        private void SchedulerDataStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            List<TimeSheet> timeSheetData = new List<TimeSheet>();
            timeSheetData = timeSheetBUS.getTimeSheets();
            int id = Convert.ToInt32(timeSheetData[timeSheetData.Count - 1].Id);
            scTimeSheet.DataStorage.Appointments[timeSheetData.Count - 1].SetId(id);
        }

        private void SchedulerDataStorage1_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {
            timeSheet = new TimeSheet();
            timeSheet.StartTime = ((Appointment)e.Object).Start;
            timeSheet.EndTime = ((Appointment)e.Object).End;
            timeSheet.Id = Convert.ToInt32(((Appointment)e.Object).Id);
            string subject = ((Appointment)e.Object).Subject;
            timeSheet.StaffID = staffBUS.getIdByName(subject);
            timeSheet.Color = Convert.ToInt32(((Appointment)e.Object).LabelKey);
            timeSheet.Location = ((Appointment)e.Object).Location;
            timeSheetBUS.updateSheets(timeSheet);

        }

        private void SchedulerDataStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            TimeSheet ts = new TimeSheet();
            string staffName = ((Appointment)e.Object).Subject;
            ts.StaffID = staffBUS.getIdByName(staffName);
            timeSheetBUS.deleteSheet(ts.StaffID,Convert.ToDateTime(((Appointment)e.Object).Start), Convert.ToDateTime(((Appointment)e.Object).End));
        }

        private void SchedulerDataStorage1_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e)
        {
            // add
            
            TimeSheet ts = new TimeSheet();
            ts.StartTime = ((Appointment)e.Object).Start;
            ts.EndTime = ((Appointment)e.Object).End;
            ts.Color = Convert.ToInt32(((Appointment)e.Object).LabelKey);
            string staffName = ((Appointment)e.Object).Subject;
            ts.StaffID = staffBUS.getIdByName(staffName);
            ts.Location =  ((Appointment)e.Object).Location;
            if (ts.StaffID == -1)
            {
                MessageBox.Show("Không tồn tại nhân viên với tên này!");
                e.Cancel = true;
                return;
            }
            timeSheetBUS.addSheets(ts);
           
            //loadShifts();


        }

        public void loadShifts()
        {

            List<TimeSheet> timeSheetData = new List<TimeSheet>();
            timeSheetData = timeSheetBUS.getTimeSheets();
            foreach(TimeSheet ts in timeSheetData)
            {
                Appointment app = this.schedulerDataStorage1.CreateAppointment(AppointmentType.Normal);
                staff = staffBUS.getStaffById(ts.StaffID);
                app.SetId(ts.Id);
                app.Start = ts.StartTime;
                app.End = ts.EndTime;
                app.Subject = staff.Name;
                app.AllDay = false;
                app.LabelKey = ts.Color;
                app.Location = ts.Location;
                schedulerDataStorage1.Appointments.Add(app);

            }
            return;
        }

        private void scTimeSheet_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {

        }

        private void frmScheduler_Load(object sender, EventArgs e)
        {

        }

        private void frmScheduler_FormClosing(object sender, FormClosingEventArgs e)
        {

            

        
            
        }

        private void scTimeSheet_StorageChanged(object sender, EventArgs e)
        {

        }

        private void scTimeSheet_Click(object sender, EventArgs e)
        {

        }
    }
   
}