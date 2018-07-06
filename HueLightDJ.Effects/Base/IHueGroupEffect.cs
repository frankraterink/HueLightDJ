using Q42.HueApi.ColorConverters;
using Q42.HueApi.Streaming.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HueLightDJ.Effects
{
  public interface IHueGroupEffect
		  {
					Task Start(IEnumerable<IEnumerable<EntertainmentLight>> lights,
                              Ref<TimeSpan?> waitTime,
                              RGBColor? color,
                              CancellationToken cancellationToken);
		  }
}
