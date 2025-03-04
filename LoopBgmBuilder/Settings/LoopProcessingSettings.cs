﻿using System.Collections.Generic;

namespace LoopBgmBuilder.Settings
{
    /// <summary>
    /// WAVE 形式の BGM をループ加工する為の設定を格納します。
    /// </summary>
    public record LoopProcessingSettings(
        DefaultOutputFormatSettings DefaultOutputFormat,
        IEnumerable<ExtractionSettings> Extractions)
    {
        /// <summary>
        /// インスタンスの状態を検証し、検証に失敗した場合は例外をスローします。
        /// </summary>
        public void ThrowIfValidationFailed()
        {
            DefaultOutputFormat.ThrowIfValidationFailed();
            foreach(var extraction in Extractions)
            {
                extraction.ThrowIfValidationFailed();
            }
        }
    }
}
