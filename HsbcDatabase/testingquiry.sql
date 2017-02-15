--select accountNo from Accounts where Substring(accountNo, 1, 1) = 'a';

select MAX( SUBSTRING(accountNo, 3,3)) as topAccount from Accounts where Substring(accountNo, 1, 1) = 'a';
