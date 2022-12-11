import xml.etree.ElementTree as ET
import xmlrpc.client

url ='http://localhost:8069/xmlrpc/'
DB='net'
USER='gbonanno@uoc.edu'
PASS='admin'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)

#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('/Flota/python/GestionRuta.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_pedido','create',[{
            'x_idGestionRuta':subraiz[0].text,
            'x_volumen':subraiz[1].text,
            'x_fechaEnvio':subraiz[2].text,
            'x_conductor':subraiz[3].text,
            'x_mercancia':subraiz[4].text,
            'x_vohiculo':subraiz[5].text,
            'x_ruta':subraiz[6].text,
            }])
    print('Pedidos Cargados correctamente')
else:
    print('Error al conectar a Odoo')