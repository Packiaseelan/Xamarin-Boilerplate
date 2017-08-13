﻿using XamarinBoilerplate.Core.Services;
using Xunit;

namespace XamarinBoilerplate.Core.Test.Service
{
    public abstract class AssetServiceTest
    {
        protected readonly IAssetService AssetService;

        protected AssetServiceTest(IAssetService assetService)
        {
            AssetService = assetService;
        }

        public void ReadAssetText_ShouldLoadTextFromFile(string path, string expected)
        {
            var text = AssetService.ReadAssetText(path);
            Assert.Equal(expected, text);
        }
    }
}
