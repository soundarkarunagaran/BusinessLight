﻿using System.Collections.Generic;

namespace BusinessLight.PhoneBook.Dto
{
    public class ContactDetailDto : ContactDto
    {
        public ICollection<ContactInfoDto> ContactInfos { get; set; }
    }
}