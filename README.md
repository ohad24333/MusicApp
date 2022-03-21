# MusicApp מסמך אפיון
### שם : אוהד סעדיה


הפרוייקט הוא אפליקצית מוזיקה (השראה מYUOTUBE): 

האפליקציה מאפשרת הרשמה של משתמשים חדשים, 

התחברות והתנתקות של משתמשים קיימים, 

מנגנון "שכחתי סיסמא" שמדמה שליחה של אימייל עם הסיסמא על MBOX. 

### משתמש פשוט: 
 * משתמשים פשוטים יכולים לחפש שירים לפי שם שיר או שם אומן, בחיפוש ניתן לכתוב רק חלק משם השיר או האומן (מחפש לפי STARTWITH)
 * המשתמש יכול להפעיל שיר (לא באמת מנגן שיר אודיו אלא מציג על המסך)
 * כאשר המשתמש מפעיל שיר השיר נכנס לListening History (מופיע רק פעם אחת ברשימה עם תאריך השמעה אחרונה)
 * המשתמש יכול להוסיף שיר אל רשימת שירים שמורים של המשתמש וגם להסיר שירים קיימים מהרשימה. 


### משתמש אדמין: 
* יכול לעשות כל מה שמשתמש רגיל יכול לעשות
* משתמש אדמין יכול לחפש , לערוך, למחוק, להוסיף, משתמשים, אומנים ושירים.


### ולידציות
האפליקציה עושה ולידציות על האינסרטים של היוזר , 
 אימייל : רק \@gmail|\@yahoo|@walla , 
שם פרטי : אותיות 2-10 
 שם משפחה : אותיות 2-10, 
 הסיסמא יכולה להיות כל תו.  
 
 האפליקציה אינה עושה ולידציה על שם שיר או שם במה של אומן.

### טבלאות
כדי לבנות את הטבלאות הרלוונטיות, צור DataBase חדש והכנס את ה - ConnectionString במחלקת ה MusicAppDBContext, 

 לאחר מכן הפעל Update-DataBase בטרמינל. 
