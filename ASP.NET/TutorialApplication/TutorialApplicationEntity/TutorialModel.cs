﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialApplicationEntity
{
    public class TutorialModel
    {
        public int TutorialId { get; set; }
        public string TutorialName { get; set; }
        public string TutorialDesc { get; set; }
        public string Published { get; set; }
        public int TutorialFee { get; set; }
    }
}
