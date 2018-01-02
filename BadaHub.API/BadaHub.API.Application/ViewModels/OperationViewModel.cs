using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BadaHub.API.Domain.Commands;

namespace BadaHub.API.Application.ViewModels
{
    public class OperationViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Type is Required")]
        [DisplayName("Type")]
        public OperationType Type { get; set; }

        [Required(ErrorMessage = "The Payload is Required")]
        [DisplayName("Payload")]
        public string Payload { get; set; }

        public DateTime Timestamp { get; set; }
        public ValidationResult ValidationResult { get; set; }
        public string MessageType { get; set; }
        public Guid AggregateId { get; set; }
    }
}
