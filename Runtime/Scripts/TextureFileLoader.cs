﻿// Copyright (c) 2019 Andreas Atteneder, All Rights Reserved.

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace KtxUnity {
    public abstract class TextureFileLoader<TextureType> : TextureLoaderBase where TextureType:TextureBase,new()
    {
        public string filePath;
        public bool linear;

        protected virtual void Start() {
            LoadFromStreamingAssets();
        }

        /// <summary>
        /// Demonstrates how to load a texture file from the StreamingAssets
        /// folder (see https://docs.unity3d.com/Manual/StreamingAssets.html)
        /// </summary>
        protected void LoadFromStreamingAssets(TextureType txt = null) {
            texture = txt==null ? new TextureType() : txt;
            texture.onTextureLoaded += OnTextureLoaded;
            texture.LoadFromStreamingAssets(filePath,this,linear);
        }
    }
}
