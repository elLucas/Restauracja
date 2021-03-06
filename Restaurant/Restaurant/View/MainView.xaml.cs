﻿using System.Windows.Controls;

namespace Restaurant.View
{
    public partial class MainView : UserControl
    {
        private readonly DTO.WorkerDto _workerDto;

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

        public MainView(DTO.WorkerDto workerDto)
        {
            InitializeComponent();
            _workerDto = workerDto;
            nameLabel.Content = UserName;
        }
    }
}
