using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zen.Model
{
    public abstract class BaseEntity : IXafEntityObject
    {
        [Key, Browsable(false)]
        public virtual int Id { get; set; }
        public virtual void OnCreated() { }
        public virtual void OnSaving() { }
        public virtual void OnLoaded() { }
    }
}
