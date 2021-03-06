﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest
{
	[JsonObject]
	public class ShardsMetadata
	{
		[JsonProperty]
		public int Total { get; internal set; }

		[JsonProperty]
		public int Successful { get; internal set; }

		[JsonProperty]
		public int Failed { get; internal set; }

		[JsonProperty("failures")]
		public IReadOnlyCollection<ShardFailure> Failures { get; internal set; } = EmptyReadOnly<ShardFailure>.Collection;

	}
}
