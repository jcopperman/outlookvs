Feature: Outlook Add-in insert text in email body
	Programatically insert text into a the body of a new email

@mytag
Scenario: Insert text into email body
	Given Outlook is running
	And I compose a new email 
	When I click send
	Then the text "This text was added by using code" is inserted into the email's body
