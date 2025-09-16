using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Tour : BaseEntity
    {
        public virtual string? Destination { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual float? Price { get; set; }
        public virtual int? Capacity { get; set; }
        public virtual Guide? Guide { get; set; }

        [InverseProperty("Tours")]
        public virtual IList<Guide> Guides { get; set; } = new ObservableCollection<Guide>();
    }
}
