﻿using Microsoft.TemplateEngine.Abstractions;
using Microsoft.Templates.Core;
using Microsoft.Templates.Core.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Templates.UI.ViewModels
{
    public class TemplateInfoViewModel : Observable
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _templateName;
        public string TemplateName
        {
            get => _templateName;
            set => SetProperty(ref _templateName, value);
        }


        private string _author;
        public string Author
        {
            get => _author;
            set => SetProperty(ref _author, value);
        }

        private string _summary;
        public string Summary
        {
            get { return _summary; }
            set { SetProperty(ref _summary, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _icon;
        public string Icon
        {
            get { return _icon; }
            set { SetProperty(ref _icon, value); }
        }

        private string _version;
        public string Version
        {
            get { return _version; }
            set { SetProperty(ref _version, value); }
        }

        private int _order;
        public int Order
        {
            get { return _order; }
            set { SetProperty(ref _order, value); }
        }

        private bool _multipleInstances;
        public bool MultipleInstances
        {
            get { return _multipleInstances; }
            set { SetProperty(ref _multipleInstances, value); }
        }

        private IEnumerable<TemplateLicense> _licenseTerms;
        public IEnumerable<TemplateLicense> LicenseTerms
        {
            get { return _licenseTerms; }
            set { SetProperty(ref _licenseTerms, value); }
        }

        private string _group;
        public string Group
        {
            get { return _group; }
            set { SetProperty(ref _group, value); }
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        private string _dependencies;
        public string Dependencies
        {
            get { return _dependencies; }
            set { SetProperty(ref _dependencies, value); }
        }

        private TemplateType _templateType;
        public TemplateType TemplateType
        {
            get { return _templateType; }
            set { SetProperty(ref _templateType, value); }
        }

        public ITemplateInfo Template { get; set; }

        private bool _hasDefaultName;
        public bool HasDefaultName
        {
            get => _hasDefaultName;
            set => SetProperty(ref _hasDefaultName, value);
        }

        public TemplateInfoViewModel(ITemplateInfo template, IEnumerable<ITemplateInfo> dependencies)
        {
            Name = template.Name;
            Summary = template.Description;
            Description = template.GetRichDescription();
            Author = template.Author;
            Icon = template.GetIcon();
            Version = template.GetVersion();
            Order = template.GetOrder();
            MultipleInstances = template.GetMultipleInstance();
            TemplateType = template.GetTemplateType();
            Template = template;
            Dependencies = string.Join(",", dependencies.Select(d => d.Name));
            LicenseTerms = template.GetLicenses();
            Group = template.GetGroup();
        }
    }
}
 