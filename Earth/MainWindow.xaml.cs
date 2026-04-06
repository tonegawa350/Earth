using System;
using System.Collections.Generic;
using System.Windows;

namespace Earth
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TodayLabel.Text = DateTime.Today.ToString("yyyy年M月d日（ddd）");
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            var schedule = new List<ScheduleItem>
            {
                new ScheduleItem { Time = "09:00", Title = "朝会・チームミーティング" },
                new ScheduleItem { Time = "10:00", Title = "タスク作業" },
                new ScheduleItem { Time = "12:00", Title = "昼休み" },
                new ScheduleItem { Time = "13:00", Title = "午後の作業" },
                new ScheduleItem { Time = "15:00", Title = "進捗確認" },
                new ScheduleItem { Time = "17:00", Title = "業務終了・振り返り" },
            };
            ScheduleList.ItemsSource = schedule;
        }
    }

    public class ScheduleItem
    {
        public string Time { get; set; }
        public string Title { get; set; }
    }
}
