﻿using System.Threading.Tasks;
using Bonsai.Areas.Front.Logic;
using Bonsai.Areas.Front.Logic.Auth;
using Bonsai.Code.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bonsai.Areas.Front.Controllers
{
    /// <summary>
    /// The controller for displaying media information.
    /// </summary>
    [Area("Front")]
    [Route("m")]
    [Authorize(Policy = AuthRequirement.Name)]
    public class MediaController: AppControllerBase
    {
        public MediaController(MediaPresenterService media)
        {
            _media = media;
        }

        private readonly MediaPresenterService _media;

        /// <summary>
        /// Displays media and details.
        /// </summary>
        [Route("{key}")]
        public async Task<ActionResult> ViewMedia(string key)
        {
            var vm = await _media.GetMediaAsync(key)
                                 .ConfigureAwait(false);

            return View(vm);
        }
    }
}
