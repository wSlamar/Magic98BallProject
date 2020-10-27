Use Master
Go

Drop Database if exists Magic8Ball

Create Database Magic8Ball

Use Magic8Ball
Go

Create Table Questions (
	questionNumber int Identity Primary Key,
	Question nvarchar(200) not null
)

INSERT into Questions(Question)
	Values ('Indeed!'),
			('Yes!')

INSERT into Questions(Question)
	Values ('No.'),
			('As I see it, yes.'),
			('Ask again later.'),
			('Better not tell you now.'),
			('Cannot predict now.'),
			('Concentrate and ask again.'),
			(' Don’t count on it.'),
			('It is certain.'),
			('It is decidedly so.'),
			('Most likely.'),
			('My reply is no.'),
			('My sources say no.'),
			('Outlook not so good.'),
			('Outlook good.'),
			('Reply hazy, try again.'),
			('Signs point to yes.'),
			('Very doubtful.'),
			('Without a doubt.'),
			('Yes – definitely.'),
			('You may rely on it.')
			
Select * from Questions

Update Questions
	Set Question = 'Don’t count on it.'
	Where Question = ' Don’t count on it.'

INSERT into Questions(Question)
		Values ('That is a strange question.. Try again.'),
				('Probably not.'),
				('Mabye yes.. Mabye no..'),
				('I dont like that question.. Try again.'),
				('I guess so.'),
				('I dont think so.'),
				('Sure.'),
				('Esta es una pregunta tonta.. Vuelve a intentarlo.'),
				('I think so!'),
				('Maybe someday.')

INSERT into Questions(Question)
		Values ('My sources say yes!'),
				('My sources say mabye.'),
				('Signs point to no.'),
				('You should not rely on it.'),
				('As I see it, no.'),
				('Very doubtful but it is a possibility.'),
				('I wish I could say yes but the answer is no.'),
				('I wish I could say no but the answer is yes.'),
				('You wish.'),
				('*zzz* *zzz* *zzz* - Oh sorry I was sleeping, what was your question again?'),
				('You already know the answer to that question.')

INSERT into Questions(Question)
		Values ('Im not happy about it but your answer is yes.'),
				('Im not happy about it but your answer is no.'),
				('Im really not sure.'),
				('Im happy to tell you that your answer is yes!'),
				('Im happy to tell you that your answer is no.'),
				('*zzz*'),
				('Wow that is a great question! Too bad I dont have an answer for you..'),
				('You wont like the answer I have for that question.'),
				('I think you already know the answer to that question.'),
				('Im just a random answer generator, how would I know?')

INSERT into Questions(Question)
		Values ('"Error caught: System.StackOverflowException: Exception of type System.StackOverflowException was thrown." - Whoops! I think somthing went wrong!'),
			('"fbd39fe0ecd01afaf01ea1957ef4a57c" - Whoops! I think your answer got generated into MD5!'),
			('"b127099c71415d532da3a26ed73eb041" - Whoops! I think your answer got generated into MD5!'),
			('As I see it, yes.'),
			('Ask again later.'),
			('Better not tell you now.'),
			('Cannot predict now.'),
			('Concentrate and ask again.'),
			(' Don’t count on it.'),
			('It is certain.'),
			('It is decidedly so.'),
			('Most likely.'),
			('My reply is no.'),
			('My sources say no.'),
			('Outlook not so good.'),
			('Outlook good.'),
			('Reply hazy, try again.'),
			('Signs point to yes.'),
			('Very doubtful.'),
			('Without a doubt.'),
			('Yes – definitely.'),
			('You may rely on it.')

INSERT into Questions(Question)
		Values ('That is a strange question.. Try again.'),
				('Probably not.'),
				('Mabye yes.. Mabye no..'),
				('I dont like that question.. Try again.'),
				('I guess so.'),
				('I dont think so.'),
				('Sure.'),
				('Esta es una pregunta tonta.. Vuelve a intentarlo.'),
				('I think so!'),
				('Maybe someday.')

INSERT into Questions(Question)
		Values ('Magic 98 Ball says "no".'),
			('Magic 98 Ball says "yes".'),
			('Magic 98 Ball says "mabye".'),
			('Magic 98 Ball says "I guess so".'),
			('Magic 98 Ball says "sure".'),
			('Magic 98 Ball says "it is certain".')

Select * from Questions

Insert into Questions(Question)
	Values 	('As I see it, no.'),
				('Very doubtful but it is a possibility.'),
				('I wish I could say yes but the answer is no.'),
				('I wish I could say no but the answer is yes.'),
				('You wish.'),
				('*zzz* *zzz* *zzz* - Oh sorry I was sleeping, what was your question again?'),
				('You already know the answer to that question.')


select top 1 * from Questions order by newid()
