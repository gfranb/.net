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
    archivo_xml = ET.parse('/Flota/python/mercancias.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_mercancia','create',[{
            'x_idProducto':subraiz[0].text,
            'x_nombre':subraiz[1].text,
            'x_volumenProducto':subraiz[2].text,
        }])
    print('Mercancia Cargados correctamente')
else:
    print('Error al conectar a Odoo')