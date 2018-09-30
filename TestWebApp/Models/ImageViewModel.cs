using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Models
{
    public class ImageViewModel
    {
        public enum CameraResolution
        {
            //3280x2464 - 8MP?, or 3264x2448;  Megapixel; ; ; 
            [Display(Name = "640x480 (0.3 MP)")]
            _640x480_03MP,
            [Display(Name = "1024x768")]
            _1024x768,
            [Display(Name = "1280x960 (1 MP)")]
            _1280x960_1MP,
            [Display(Name = "1600x1200 (2 MP)")]
            _1600x1200_2MP,
            [Display(Name = "2560x1920 (5 MP)")]
            _2560x1920_5MP
        }

        //[EnumDataType(typeof(CameraResolution))]
        public CameraResolution Resolution { get; set; }

        [Required, Display(Name = "Capture timeout (ms)")]
        public int CaptureTimeoutMilliseconds { get; set; }

        [Required, Display(Name = "Image encoding")]
        public string ImageEncoding { get; set; }

        [Display(Name = "Flip image vertically")]
        public bool VerticalFlip { get; set; }

        [Range(640, 2560, ErrorMessage = "Valid widths are 640, 1024, 1280, 1600, 2560")]
        public int ImageWidth { get; set; }

        [Range(480, 1920, ErrorMessage = "Valid heights are 480, 768, 960, 1200, 1920")]
        public int ImageHeight { get; set; }

        public string ImageData { get; set; }

        //public SelectList GetResolutions()
        //{
        //    var result = new List<SelectListItem>();
            
        //    var enumValues = Enum.GetValues(typeof(CameraResolution));
        //    //var enumNames = Enum.GetNames(typeof(CameraResolution));
        //    foreach (var resEntry in enumValues)
        //    {
        //        var entryName = Enum.GetName(typeof(CameraResolution), resEntry);
        //        result.Add(new SelectListItem(entryName, entryName));
        //            //resEntry.GetType()?.GetAttribute<DisplayAttribute>(), ));
        //    }
        //    return new SelectList(result);
        //}

        //public static string GetDisplayName(Enum enumValue)
        //{
        //    return enumValue.GetType()?
        //   .GetMember(enumValue.ToString())?[0]?
        //   .GetCustomAttribute<DisplayAttribute>()?
        //   .Name;
        //}
    }
}
