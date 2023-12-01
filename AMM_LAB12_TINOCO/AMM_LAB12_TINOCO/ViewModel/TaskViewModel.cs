﻿using AMM_LAB12_TINOCO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;
using Xamarin.Forms;

namespace AMM_LAB12_TINOCO.ViewModel
{
    public class TaskViewModel : ViewModelBase
    {
        private string title;
        public string Title { 
            get {return title;}
            set
            {
                if (title != value)
                {
                    title= value;
                    OnPropertyChanged();
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description;}
            set 
            { 
                if (description != value)
                {
                    description= value;
                    OnPropertyChanged();
                } 
            }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set
            {

                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<TaskModel> tasks;
        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if(tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        public TaskViewModel()
        {
            Save = new Command(() =>
            {
                TaskModel x = new TaskModel(Title, Status, Description);
                Console.WriteLine(x);
                Description= x.Title;
                Tasks.Add(new TaskModel(Title, Status, Description));
            });

            Get = new Command(() =>
            {
                
            });
        }
    }
}