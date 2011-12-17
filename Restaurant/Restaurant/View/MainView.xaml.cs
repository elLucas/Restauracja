using System.Windows.Controls;

namespace Restaurant.View
{
    public partial class MainView : UserControl
    {
        private readonly WebService.WorkerDto _workerDto;

        public string UserName
        {
            get
            {
                if (_workerDto != null)
                {
                    return _workerDto.Name + " " + _workerDto.Surname;
                }
                return "";
            }
        }

        public MainView(WebService.WorkerDto workerDto)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            _workerDto = workerDto;
            nameLabel.Content = UserName;
        }
    }
}
