﻿
namespace MediaBrowser.Controller.Entities
{
    /// <summary>
    /// Plugins derive from and export this class to create a folder that will appear in the root along
    /// with all the other actual physical folders in the system.
    /// </summary>
    public abstract class BasePluginFolder : Folder, ICollectionFolder, IByReferenceItem
    {
        public virtual string CollectionType
        {
            get { return null; }
        }
    }
}
