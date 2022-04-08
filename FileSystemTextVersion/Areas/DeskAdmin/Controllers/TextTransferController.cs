using FileSystemBAL.Repository.IRepository;
using FileSystemBAL.TextTransferRecord.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static FileSystemUtility.Utilities.CommonConstant;

namespace FileSystemTextVersion.Areas.DeskAdmin.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    [Area("DeskAdmin")]
    public class TextTransferController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public TextTransferController(IUnitOfWork foUnitOfWork)
        {
            unitOfWork = foUnitOfWork;  
        }
        public IActionResult Index()
        {
            List<TextTransferRecord> textRecord = new List<TextTransferRecord>();
            textRecord = unitOfWork.TextTranferRepository.GetTextTransferRecords(/*Convert.ToInt32(User.FindFirst(SessionConstant.Id).Value)*/1 );
            return View("~/Areas/DeskAdmin/Views/TextTransfer/TextTransferList.cshtml",textRecord);
        }
        public IActionResult SaveTextTransfer()
        {
            return View();
        }
    }
}
