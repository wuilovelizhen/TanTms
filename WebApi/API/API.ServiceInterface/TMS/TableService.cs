﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.ServiceModel;
using WebApi.ServiceModel.TMS;

namespace WebApi.ServiceInterface.TMS
{
    public class TableService
    {
       

        public void TS_Rcbp(Auth auth, Rcbp request, Rcbp_Logic rcbp_logic, CommonResponse ecr, string[] token, string uri)
        {
            if (auth.AuthResult(token, uri))
            {
                if (uri.IndexOf("/tms/rcbp1") > 0)
                {
                    ecr.data.results = rcbp_logic.Get_rcbp1_List(request);
                }
                ecr.meta.code = 200;
                ecr.meta.message = "OK";
            }
            else
            {
                ecr.meta.code = 401;
                ecr.meta.message = "Unauthorized";
            }
        }


        public void DownLoadImg(Auth auth, DownLoadImg request, DownLoadImg_Logic logic, CommonResponse ecr, string[] token, string uri)
        {
            if (auth.AuthResult(token, uri))
            {
                if (uri.IndexOf("/tms/csbk1/attach") > 0)
                {
                    ecr.data.results = logic.Get_Jmjm1_Attach_List(request);
                }
                if (uri.IndexOf("/tms/jmjm1/doc") > 0)
                {
                    //ecr.data.results = logic.Get_Jmjm1_Doc_List(request);
                }
                ecr.meta.code = 200;
                ecr.meta.message = "OK";
            }
            else
            {
                ecr.meta.code = 401;
                ecr.meta.message = "Unauthorized";
            }
        }

    }
}
