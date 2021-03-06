using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q42.HueApi.Streaming.Extensions;

namespace HueLightDJ.Web.Models
{
    public class EffectLogMsg
    {
    public string EffectType { get; set; }
    public string Name { get; set; }
    public string RGBColor { get; set; }
    public string Group { get; set; }
    public string IteratorMode { get; set; }
    public string SecondaryIteratorMode { get; set; }
  }
}
