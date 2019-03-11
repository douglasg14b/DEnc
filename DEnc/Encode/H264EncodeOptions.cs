﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DEnc
{
    /// <summary>
    /// A set of encoder options for h.264 encoding in ffmpeg using sane defaults. Default values may change over time, so if you require 
    /// </summary>
    public class H264EncodeOptions : IEncodeOptions
    {
        /// <summary>
        /// Flags for ffmpeg itself, not individual encode streams.
        /// </summary>
        public ICollection<string> AdditionalFlags { get; set; } = new List<string>();
        /// <summary>
        /// Flags to be applied to every audio stream. You can add flags, but the defaults set may be important to the generation of a valid DASH file, so avoid changing them unless you know what they do.
        /// </summary>
        public ICollection<string> AdditionalAudioFlags { get; set; } = new List<string>() { "-sn", "-ignore_unknown", "-map_chapters -1" };
        /// <summary>
        /// Flags to be applied to every video stream. You can add flags, but the defaults set may be important to the generation of a valid DASH file, so avoid changing them unless you know what they do.
        /// </summary>
        public ICollection<string> AdditionalVideoFlags { get; set; } = new List<string>() { "-sn", "-ignore_unknown", "-map_chapters -1" };

        /// <summary>
        /// 
        /// </summary>
        public H264EncodeOptions()
        {
        }
    }
}
