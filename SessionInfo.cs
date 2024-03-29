﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesiSoaClient
{
    internal class SessionInfo
    {

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private string _identifier;
        public string Identifier { get { return _identifier; } }

        private DateTime _createdAt;
        public DateTime CreatedAt { get { return _createdAt; } }

        private List<Api.BlockData> _blocks;
        public List<Api.BlockData> Blocks { get { return _blocks; } set { _blocks.Clear();  _blocks.AddRange(value); } }

        public SessionInfo() {
            _name = string.Empty;
            _description = string.Empty;
            _createdAt = DateTime.Now;
            _identifier = String.Concat("session_", _createdAt.ToString("yyyyMMdd_HHmmss"));
            _blocks = new();
            //_identifier =  String.Concat("session_", _createdAt.Year, _createdAt.Month, _createdAt.Day, "_",_createdAt.Hour, _createdAt.Minute, _createdAt.Second);
        }
    }
}
