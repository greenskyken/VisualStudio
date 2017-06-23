--All Lenel Card Tranactions - Access Granted only

use DBCAMASTERAC

declare @Date_Event datetime = convert(datetime, '2014-09-01 00:00')

select
	cast(EVENTS.EVENT_TIME_UTC as DATE) as Access_Date_UTC,
	convert(varchar(10),EVENTS.EVENT_TIME_UTC,108) as Access_Time_UTC,
	READER.READERDESC as Device_ID,
	EVENTYPE.EVTDESCR as Event_Type,
	EMP.FIRSTNAME as First_Name,
	EMP.LASTNAME as Last_Name,
	EVENTS.CARDNUM as Badge
from
	EVENTS
		join EVENTYPE
			on EVENTS.EVENTTYPE = EVENTYPE.EVTYPEID
		join BADGE
			on EVENTS.CARDNUM = BADGE.ID
		join EMP
			on BADGE.EMPID = EMP.ID
		join READER
			on EVENTS.DEVID = READER.READERID
		and EVENTS.MACHINE = READER.PANELID 
where
	EVENT_TIME_UTC >= @Date_Event and
		(EVENTTYPE = 0) /*granted*/

order by Access_Date_UTC, Access_Time_UTC