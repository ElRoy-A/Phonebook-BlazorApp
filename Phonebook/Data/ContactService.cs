using Microsoft.EntityFrameworkCore;

namespace Phonebook.Data
{
    public class ContactService
    {
        // Property
        private readonly AppDBContext _appDBContext;

        // Constructor
        public ContactService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // List of Contacts
        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await _appDBContext.Contacts.ToListAsync();
        }

        // List a Contact
        public async Task<Contact> GetContactAsync(int id)
        {
            Contact contact = await _appDBContext.Contacts.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return contact;
        }

        // Create Contact
        public async Task<bool> CreateContactAsync(Contact contact)
        {
            await _appDBContext.Contacts.AddAsync(contact);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update Contact
        public async Task<bool> UpdateContactAsync(Contact contact)
        {
            _appDBContext.Contacts.Update(contact);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete Contact
        public async Task<bool> DeleteContactAsync(Contact contact)
        {
            _appDBContext.Contacts.Remove(contact);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}
