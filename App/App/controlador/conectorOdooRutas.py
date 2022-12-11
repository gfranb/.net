import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'http://localhost:8069/xmlrpc/'
DB='net'
USER='gbonanno@uoc.edu'
PASS='admin'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)

#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('/Flota/python/rutas.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_ruta','create',[{
            'x_idRuta':subraiz[0].text,
            'x_origen_ruta':subraiz[1].text,
            'x_destino_ruta':subraiz[2].text,
            'x_repostar_gasolina':subraiz[3].text,
            'x_duracion':subraiz[4].text,
            'x_precio_repostaje':subraiz[5].text,
            'x_kms_ruta':subraiz[6].text,
            }])
    print('Ruta Cargados correctamente')
else:
    print('Error al conectar a Odoo')