﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DraftManager : IDraftService
    {
        IDraftDal _draftDal;

        public DraftManager(IDraftDal draftDal)
        {
            _draftDal = draftDal;
        }

        public void DraftAdd(Draft draft)
        {
            _draftDal.Insert(draft);
        }

        public void DraftDelete(Draft draft)
        {
            _draftDal.Delete(draft);
        }

        public void DraftUpdate(Draft draft)
        {
            _draftDal.Update(draft);
        }

        public Draft GetByID(int id)
        {
            return _draftDal.Get(x => x.DraftID == id);
        }

        public List<Draft> GetList()
        {
            return _draftDal.List();
        }
    }
}
