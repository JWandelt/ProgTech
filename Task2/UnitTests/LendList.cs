﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace UnitTests
{
    public class LendList : Ilend_list
    {
        private decimal _lend_listID;
        private decimal _bookID;
        private decimal _readerID;

        public LendList(decimal lend_listID, decimal bookID, decimal readerID)
        {
            this.bookID = bookID;
            this.lend_listID = lend_listID;
            this.readerID = readerID;
        }

        public decimal bookID { get { return _bookID; } set { _bookID = value; } }
        public decimal lend_listID { get { return _lend_listID; } set { _lend_listID = value;} }
        public decimal readerID { get { return _readerID; } set { _readerID = value;} }

        public book book { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public registered_reader registered_reader { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
    }
}
