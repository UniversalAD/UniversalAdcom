﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversalAdcom.Models
{
    public class Extensions
    {
        public static IEnumerable<SelectListItem> GetPrefixList()
        {
            IList<SelectListItem> prefix = new List<SelectListItem>
            {
                new SelectListItem() {Text="Afghanistan", Value="+93"},
                new SelectListItem() {Text="Albania", Value="+355"},
                new SelectListItem() {Text="Algeria", Value="+213"},
                new SelectListItem() {Text="American Samoa", Value="+1-684"},
                new SelectListItem() {Text="Andorra", Value="+376" },
                new SelectListItem() {Text="Angola", Value="+244"},
                new SelectListItem() {Text="Anguilla", Value="+1-264"},
                new SelectListItem() {Text="Antarctica", Value="+672"},
                new SelectListItem() {Text="Antigua", Value="+1-268"},
                new SelectListItem() {Text="Argentina", Value="+54"},
                new SelectListItem() {Text="Armenia", Value="+372"},
                new SelectListItem() {Text="Aruba", Value="+297"},
                new SelectListItem() {Text="Australia", Value="+61"},
                new SelectListItem() {Text="Austria", Value="+43"},
                new SelectListItem() {Text="Azerbaijan", Value="+994"},
                new SelectListItem() {Text="Bahamas", Value="+1-242"},
                new SelectListItem() {Text="Bahrain", Value="+973"},
                new SelectListItem() {Text="Bangladesh", Value="+880"},
                new SelectListItem() {Text="Barbados", Value="+1-246"},
                new SelectListItem() {Text="Belarus", Value="+375"},
                new SelectListItem() {Text="Belgium", Value="+32"},
                new SelectListItem() {Text="Belize", Value="+501"},
                new SelectListItem() {Text="Benin", Value="+229"},
                new SelectListItem() {Text="Bermuda", Value="+1-441"},
                new SelectListItem() {Text="Bhutan", Value="+975"},
                new SelectListItem() {Text="Bolivia", Value="+591"},
                new SelectListItem() {Text="Bosnia and Herzegovina", Value="+387"},
                new SelectListItem() {Text="Botswana", Value="+267"},
                new SelectListItem() {Text="Brazil", Value="+55"},
                new SelectListItem() {Text="British India Ocean Territory", Value="+246"},
                new SelectListItem() {Text="British Virgin Islands", Value="+1-284"},
                new SelectListItem() {Text="Brunei", Value="+673"},
                new SelectListItem() {Text="Bulgaria", Value="+359"},
                new SelectListItem() {Text="Burkina Faso", Value="+226"},
                new SelectListItem() {Text="Burundi", Value="+257"},
                new SelectListItem() {Text="Cambodia", Value="+855"},
                new SelectListItem() {Text="Cameroon", Value="+237"},
                new SelectListItem() {Text="Canada", Value="+1"},
                new SelectListItem() {Text="Cape Verde", Value="+238"},
                new SelectListItem() {Text="Cayman", Value="+1-345"},
                new SelectListItem() {Text="Central African-Republic", Value="+236"},
                new SelectListItem() {Text="Chad", Value="+235"},
                new SelectListItem() {Text="Chile", Value="+56"},
                new SelectListItem() {Text="China", Value="+86"},
                new SelectListItem() {Text="Christmas Island", Value="+61"},
                new SelectListItem() {Text="Cocos Islands", Value="+61"},
                new SelectListItem() {Text="Columbia", Value="+57"},
                new SelectListItem() {Text="Comoros", Value="+61"},
                new SelectListItem() {Text="Cook Islands", Value="+269"},
                new SelectListItem() {Text="Costa Rica", Value="+506"},
                new SelectListItem() {Text="Croatia", Value="+385"},
                new SelectListItem() {Text="Cuba", Value="+53"},
                new SelectListItem() {Text="Curacao", Value="+599"},
                new SelectListItem() {Text="Cyprus", Value="+357"},
                new SelectListItem() {Text="Czech Republic", Value="+420"},
                new SelectListItem() {Text="Democratic Republic of Congo", Value="+243"},
                new SelectListItem() {Text="Denmark", Value="+45"},
                new SelectListItem() {Text="Djibouti", Value="+253" },
                new SelectListItem() {Text="Dominica", Value="+1-767"},
                new SelectListItem() {Text="Dominican Republic", Value="+1-809, 1-829, 1-849"},
                new SelectListItem() {Text="East Timor", Value="+670"},
                new SelectListItem() {Text="Ecuador", Value="+593"},
                new SelectListItem() {Text="Egypt", Value="+20"},
                new SelectListItem() {Text="El Salvador", Value="+503"},
                new SelectListItem() {Text="Equatorial Guinea", Value="+240"},
                new SelectListItem() {Text="Eritrea", Value="+291"},
                new SelectListItem() {Text="Estonia", Value="+372"},
                new SelectListItem() {Text="Ethiopia", Value="+251"},
                new SelectListItem() {Text="Falkland Islands", Value="500"},
                new SelectListItem() {Text="Faroe Islands", Value="+298"},
                new SelectListItem() {Text="Fiji", Value="+679"},
                new SelectListItem() {Text="Finland", Value="+358"},
                new SelectListItem() {Text="France", Value="+33"},
                new SelectListItem() {Text="French Polynesia", Value="+689"},
                new SelectListItem() {Text="Gabon", Value="+241"},
                new SelectListItem() {Text="Georgia", Value="+995"},
                new SelectListItem() {Text="Germany", Value="Germany"},
                new SelectListItem() {Text="Ghana", Value="+49"},
                new SelectListItem() {Text="Greece", Value="+30"},
                new SelectListItem() {Text="Greenland", Value="+299"},
                new SelectListItem() {Text="Grenada", Value="+1-473"},
                new SelectListItem() {Text="Guam", Value="+1-671"},
                new SelectListItem() {Text="Guatemala", Value="+502"},
                new SelectListItem() {Text="Guernsey", Value="+44-1481"},
                new SelectListItem() {Text="Guinea", Value="+224"},
                new SelectListItem() {Text="Guinea-Bissau", Value="+245"},
                new SelectListItem() {Text="Guyana", Value="+592"},
                new SelectListItem() {Text="Haiti", Value="+509"},
                new SelectListItem() {Text="Honduras", Value="+504"},
                new SelectListItem() {Text="Hong Kong", Value="+852"},
                new SelectListItem() {Text="Hungary", Value="+36"},
                new SelectListItem() {Text="Iceland", Value="+354"},
                new SelectListItem() {Text="India", Value="+91"},
                new SelectListItem() {Text="Indonesia", Value="+62"},
                new SelectListItem() {Text="Iran", Value="+98"},
                new SelectListItem() {Text="Iraq", Value="+964"},
                new SelectListItem() {Text="Ireland", Value="+353"},
                new SelectListItem() {Text="Isle of Man", Value="+44-1624"},
                new SelectListItem() {Text="Italy", Value="+39"},
                new SelectListItem() {Text="Ivory Coast", Value="+225"},
                new SelectListItem() {Text="Jamaica", Value="+1-876"},
                new SelectListItem() {Text="Japan", Value="+81"},
                new SelectListItem() {Text="Jersey", Value="+44-1534"},
                new SelectListItem() {Text="Jordan", Value="+962"},
                new SelectListItem() {Text="Kazakhstan", Value="+7"},
                new SelectListItem() {Text="Kenya", Value="+254"},
                new SelectListItem() {Text="Kiribati", Value="+686"},
                new SelectListItem() {Text="Kosovo", Value="+383"},
                new SelectListItem() {Text="Kuwait", Value="+965"},
                new SelectListItem() {Text="Kyrgyzstan", Value="+996"},
                new SelectListItem() {Text="Laos", Value="+856"},
                new SelectListItem() {Text="Latvia", Value="+371"},
                new SelectListItem() {Text="Lebanon", Value="+961"},
                new SelectListItem() {Text="Lesotho", Value="+266"},
                new SelectListItem() {Text="Liberia", Value="+231"},
                new SelectListItem() {Text="Libya", Value="+218"},
                new SelectListItem() {Text="Liechtenstein", Value="+423"},
                new SelectListItem() {Text="Lithuania", Value="+370"},
                new SelectListItem() {Text="Luxembourg", Value="+352"},
                new SelectListItem() {Text="Macau", Value="+853"},
                new SelectListItem() {Text="Macedonia", Value="389"},
                new SelectListItem() {Text="Madagascar", Value="+261"},
                new SelectListItem() {Text="Malawi", Value="+265"},
                new SelectListItem() {Text="Malaysia", Value="+60"},
                new SelectListItem() {Text="Maldives", Value="+960"},
                new SelectListItem() {Text="Mali", Value="+223"},
                new SelectListItem() {Text="Malta", Value="+356"},
                new SelectListItem() {Text="Marshal Islands", Value="+692"},
                new SelectListItem() {Text="Mauritania", Value="+222"},
                new SelectListItem() {Text="Mauritius", Value="+230"},
                new SelectListItem() {Text="Mayotte", Value="+252"},
                new SelectListItem() {Text="Mexico", Value="+52"},
                new SelectListItem() {Text="Micronesia", Value="+691"},
                new SelectListItem() {Text="Moldova", Value="+373"},
                new SelectListItem() {Text="Manaco",Value="+377"},
                new SelectListItem() {Text="Mongolia", Value="+976"},
                new SelectListItem() {Text="Montenegro", Value="+382"},
                new SelectListItem() {Text="Montserrat", Value="+1-664"},
                new SelectListItem() {Text="Morocco", Value="+212"},
                new SelectListItem() {Text="Mozambique", Value="+258"},
                new SelectListItem() {Text="Myanmar", Value="+95"},
                new SelectListItem() {Text="Namibia", Value="+264"},
                new SelectListItem() {Text="Nauru", Value="+674"},
                new SelectListItem() {Text="Nepal", Value="+977"},
                new SelectListItem() {Text="Netherlands", Value="+31"},
                new SelectListItem() {Text="Netherlands Antilles", Value="+599"},
                new SelectListItem() {Text="New Caledonia", Value="+687"},
                new SelectListItem() {Text="New Zealand", Value="+64"},
                new SelectListItem() {Text="Nicaragua", Value="+505"},
                new SelectListItem() {Text="Niger", Value="+227"},
                new SelectListItem() {Text="Nigeria", Value="+234"},
                new SelectListItem() {Text="Niue", Value="+683"},
                new SelectListItem() {Text="North Korea", Value="+850"},
                new SelectListItem() {Text="Northern Mariana Islands", Value="+1-670"},
                new SelectListItem() {Text="Norway", Value="+47"},
                new SelectListItem() {Text="Oman", Value="+968"},
                new SelectListItem() {Text="Pakistan", Value="+92"},
                new SelectListItem() {Text="Palau", Value="+680"},
                new SelectListItem() {Text="Palestine", Value="+970"},
                new SelectListItem() {Text="Panama", Value="+507"},
                new SelectListItem() {Text="Papua New Guinea", Value="+675"},
                new SelectListItem() {Text="Peru", Value="+51"},
                new SelectListItem() {Text="Philippines", Value="+63"},
                new SelectListItem() {Text="Pitcairn", Value="+64"},
                new SelectListItem() {Text="Poland", Value="+48"},
                new SelectListItem() {Text="Portugal", Value="+351"},
                new SelectListItem() {Text="Puerto Rico", Value="+1-787, 1-939"},
                new SelectListItem() {Text="Qatar", Value="+242"},
                new SelectListItem() {Text="Republic of the Congo", Value="+242"},
                new SelectListItem() {Text="Reunion", Value="+262"},
                new SelectListItem() {Text="Romania", Value="+40"},
                new SelectListItem() {Text="Russia", Value="+7"},
                new SelectListItem() {Text="Rwanda", Value="+250"},
                new SelectListItem() {Text="Saint Barthelemy", Value="+590"},
                new SelectListItem() {Text="Saint Helena", Value="+290"},
                new SelectListItem() {Text="Saint Kitts and Nevis", Value="+1-869"},
                new SelectListItem() {Text="Saint Lucia", Value="+1-758"},
                new SelectListItem() {Text="Saint Martin", Value="+590"},
                new SelectListItem() {Text="Saint Pierre and Miquelon", Value="+508"},
                new SelectListItem() {Text="Saint Vincent", Value="+1-784"},
                new SelectListItem() {Text="Samoa", Value="+685"},
                new SelectListItem() {Text="San Marino", Value="+378"},
                new SelectListItem() {Text="Sao Tome and Principe", Value="+1-784"},
                new SelectListItem() {Text="Saudi Arabia", Value="+966"},
                new SelectListItem() {Text="Senegal", Value="+221"},
                new SelectListItem() {Text="Serbia", Value="+381"},
                new SelectListItem() {Text="Seychelles", Value="+248"},
                new SelectListItem() {Text="Sierra Leone", Value="+232"},
                new SelectListItem() {Text="Singapore", Value="+65"},
                new SelectListItem() {Text="Sint Maarten", Value="+1-721"},
                new SelectListItem() {Text="Slovakia", Value="+421"},
                new SelectListItem() {Text="Solomon Islands", Value="+677"},
                new SelectListItem() {Text="Somalia", Value="+252"},
                new SelectListItem() {Text="South Africa", Value="+27"},
                new SelectListItem() {Text="South Korea", Value="+82"},
                new SelectListItem() {Text="South Sudan", Value="+211"},
                new SelectListItem() {Text="Spain", Value="+34"},
                new SelectListItem() {Text="Sri Lanka", Value="+94"},
                new SelectListItem() {Text="Sudan", Value="+249"},
                new SelectListItem() {Text="Suriname", Value="+597"},
                new SelectListItem() {Text="Svalbard and Jan Mayen", Value="+47"},
                new SelectListItem() {Text="Swaziland", Value="+268"},
                new SelectListItem() {Text="Syria", Value="+963"},
                new SelectListItem() {Text="Taiwan", Value="+886"},
                new SelectListItem() {Text="Tajikistan", Value="+992"},
                new SelectListItem() {Text="Tanzania", Value="+255"},
                new SelectListItem() {Text="Thailand", Value="+66"},
                new SelectListItem() {Text="Togo", Value="+228"},
                new SelectListItem() {Text="Tokelau", Value="+690"},
                new SelectListItem() {Text="Tonga", Value="+676"},
                new SelectListItem() {Text="Trinidad", Value="+1-868"},
                new SelectListItem() {Text="Tunisia", Value="+216"},
                new SelectListItem() {Text="Turkey", Value="+90"},
                new SelectListItem() {Text="Turkmenistan", Value="+993"},
                new SelectListItem() {Text="Turks and Caicos Islands", Value="+1-649"},
                new SelectListItem() {Text="Tuvalu", Value="+688"},
                new SelectListItem() {Text="Uganda", Value="+256"},
                new SelectListItem() {Text="Ukraine", Value="+380"},
                new SelectListItem() {Text="United Arab Emirates", Value="+971"},
                new SelectListItem() {Text="United Kingdom", Value="+44"},
                new SelectListItem() {Text="United States", Value="+1"},
                new SelectListItem() {Text="Uruguay", Value="+598"},
                new SelectListItem() {Text="Uzbekistan", Value="+998"},
                new SelectListItem() {Text="Vanuatu", Value="+678"},
                new SelectListItem() {Text="Vatican", Value="+379"},
                new SelectListItem() {Text="Venezuela", Value="+58"},
                new SelectListItem() {Text="Vietnam", Value="+84"},
                new SelectListItem() {Text="Wallis and Futuna", Value="+681"},
                new SelectListItem() {Text="Western Sahara", Value="+212"},
                new SelectListItem() {Text="Yemen", Value="+967"},
                new SelectListItem() {Text="Zambia", Value="+260"},
                new SelectListItem() {Text="Zimbabwe", Value="+263"}
            };
            return prefix;
        }
    }
}