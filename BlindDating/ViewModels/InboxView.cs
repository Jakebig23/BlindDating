using BlindDating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlindDating.ViewModels
{
	public class InboxView
	{
		public IEnumerable<MailMessage> mailMessages;
		public IEnumerable<DatingProfile> fromProfiles;
	}
}
