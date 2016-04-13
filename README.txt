Renamed Form1 to HostForm

Tweaked and added in Login Form code
  - Employee ID is set to max length of 5
  - PIN is set to max length of 4 and an asterisk disguises the login
  -I made two log-ins
    -Host Login: Employee ID:12345 PIN:1234
	-Wait Staff: Employee ID:98765 PIN:9876
	-These are just for demonstration purposes and can be changed to match the database

Added Wait Staff Form
  -Buttons are disabled until wait staff clocks in.
  -Once clocked in Enter Order button leads to TicketForm
  -Clock in button becomes disabled to discourage multiple clock ins
  
  -Clock out button is active, reverts to login screen when clicked
  -Exit button should revert back to login screen, but keep clock in status active 
   and still stay clocked in.
	- Can't quite figure out how to get it to work
	
  -Floor status is not yet set
  -Order status not yet set
  -Cash out not yet set
  

Added in Ticket order form code 
  -Ability to pass items from one list box to other added
  -Ability to delete one or all items added