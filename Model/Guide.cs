using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Guide : BaseEntity
    {
        public virtual string? Name { get; set; }
        public virtual int? Experience { get; set; }
        public virtual string? Language { get; set; }

        [InverseProperty("Guides")]
        public virtual IList<Tour> Tours { get; set; } = new ObservableCollection<Tour>();
    }
}
