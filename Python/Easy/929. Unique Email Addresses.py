class Solution:
    def numUniqueEmails(self, emails: List[str]) -> int:
        unique_emails = set()

        for email in emails:
            local, domain = email.split('@')

            if '+' in local:
                local = local.split('+')[0]
            
            local = local.replace('.', '')

            clean_email = local + '@' + domain

            unique_emails.add(clean_email)
        
        return len(unique_emails)