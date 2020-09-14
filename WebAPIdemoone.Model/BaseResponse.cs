using System;
using System.Collections.Generic;
using System.Text;
using WebAPIdemoone.Interface;

namespace WebAPIdemoone.Model
{
    public  class BaseResponseList<T>:IBaseRespone
    {

        public BaseResponseList()
        {

            IsOk = true;

        }

        public bool IsOk { get; set; }

        public string ErrorCode { get; set; }


        public string Message { get; set; }
        public List<T> Results { get; set; }
    }
}
