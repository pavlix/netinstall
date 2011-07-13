ErrorDocument 404 /cs/notfound.html

RewriteEngine on
RewriteBase /cs

# permanent redirections
# indexed by google
RewriteRule ^training/server-software/linux/linux-beginnings$ skoleni/operacni-systemy/linux/linux-zaklady [R=permanent]
RewriteRule ^skoleni/webove-stranky-a-dokumenty/?$ skoleni/internetove-sluzby/ [R=permanent]
# other
RewriteRule ^contacts?$ kontakt [R=permanent]
RewriteRule ^kontakty$ kontakt [R=permanent]
RewriteRule ^partnershi[pb]$ reference [R=permanent]
RewriteRule ^references$ reference [R=permanent]
RewriteRule ^(sluzby|services)(/(.*))?$ $3 [R=permanent]
RewriteRule ^(services/)?servers/?$ sprava-serveru/ [R=permanent]
RewriteRule ^hardware/?$ nakup-hardware/ [R=permanent]
RewriteRule ^konektivita/?$ pripojeni-k-internetu/ [R=permanent]
# training
RewriteRule training(|/|/courses|/kurzy|/osnovy)$ skoleni/ [R=permanent]
RewriteRule (training|skoleni)/training-centers$ skoleni/skolici-strediska [R=permanent]
RewriteRule training/skolici-strediska$ skoleni/skolici-strediska [R=permanent]
RewriteRule (training|skoleni)/desktop-software/?$ skoleni/pracovni-stanice-a-notebooky/ [R=permanent]
RewriteRule (training|skoleni)/networking/?$ skoleni/pocitacove-site-a-internet/ [R=permanent]
RewriteRule (training|skoleni)/internet-services/?$ skoleni/internetove-sluzby/ [R=permanent]
RewriteRule (training|skoleni)/(networking|pocitacove-site(-a-internet)?)/ipv6/$ skoleni/pocitacove-site-a-internet/ipv6 [R=permanent]
RewriteRule (training|skoleni)/(networking|pocitacove-site)(/(.*))$ skoleni/pocitacove-site-a-internet/$4 [R=permanent]
RewriteRule (training|skoleni)/programming(/(.*))?$ skoleni/programovani/$4 [R=permanent]
RewriteRule (training|skoleni)/(web-and-documents|webove-stranky-a-tiskove-dokumenty)/?$ skoleni/webove-stranky-a-dokumenty/ [R=permanent]
RewriteRule sluzby/training/?$ skoleni/ [R=permanent]
RewriteRule sluzby/skoleni/?$ skoleni/ [R=permanent]
RewriteRule training/?$ skoleni [R=permanent]
RewriteRule training/internet-services/?$ skoleni/internetove-sluzby/ [R=permanent]
RewriteRule skoleni/programovani/tools/git$ skoleni/programovani/nastroje/git [R=permanent]
RewriteRule skoleni/servery-a-serverove-aplikace/?$ skoleni/operacni-systemy/ [R=permanent]

# suppress .html and index
RewriteCond %{REQUEST_FILENAME} !-f
RewriteCond %{REQUEST_FILENAME} !-d
RewriteRule ^([^.]*[^./])$ $1.html [L]
RewriteCond %{THE_REQUEST} "\.html "
RewriteRule ^([^.]+).html$ $1 [R=301]
RewriteCond %{THE_REQUEST} "[ /]index[ .]"
RewriteRule ^(.*/)?index(\.html|\.php)?$ $1 [R=301]

