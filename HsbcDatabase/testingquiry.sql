--select Right('000' + CONVERT(NVARCHAR, (MAX( SUBSTRING(accountNo, 3,3)) + 1)), 3)  as topAccount from Accounts where Substring(accountNo, 1, 1) = 'c'
--insert into Accounts values('SF'+ 
--(select Right('000' + CONVERT(NVARCHAR, COALESCE((MAX( SUBSTRING(accountNo, 3,3)) + 1),1)), 3)  as topAccount from Accounts where accountNo like 's%','dev','he d live')
--insert into Accounts values('SF'+ (select Format (COALESCE((MAX( SUBSTRING(accountNo, 3,3)) + 1),1), '000')  as topAccount from Accounts where accountNo like 's%'),'dev','he d li
--update Accounts set name = 'd dev' where accountNo = 'SF001' or   accountNo = 'CF001'
alter table accountNo add balance MONEY DEFAULT 0.00