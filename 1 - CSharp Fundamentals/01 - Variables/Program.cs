// Whole numbers - used for counters and general-purpose integer values
int totalProducts = 50;

// Very large whole numbers - used when whole numbers are needed but value might exceed int range
long totalWebsiteVisits = 1000000000000;

/* 
 * Single precision floating-point values when precision is not critical 
 * Common in graphics calculations when memory optimization is more important than precision
 * ~6-9 digits of precision
 */
float playerViewDistance = 1350.75f;

/* 
 * Double precision floating-point values 
 * Used when higher precision is needed but still not critical like scientific calculations
 * ~15 digits of precision
 */
double calculationResult = 15009090.132453849519;

/* 
 * High-precision decimal values
 * Used for financial calculations when precision is critical like bank account balances
 * ~28-29 digits of precision
 */
decimal accountBalance = 100500.1050m;

// Used for logical conditions, only has two valeus - true or false
bool isUserLoggedIn = true;

// Used for single characters
char studentGrade = 'A';

// Used when the type needs to be inferred
var isRunning = false;

// Used when the type needs to be inferred
var itemCount = 195;
