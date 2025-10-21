// 这是 MainPage.xaml.cs 文件的正确内容
namespace Lab_Task_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // 这是 "AdmissionTicket" 按钮的点击事件
        private void OnAdmissionTicketClicked(object sender, EventArgs e)
        {
            DisplayAlert("Ticket purchase reminder", "Function not yet open", "Confirm");
        }
    }
}